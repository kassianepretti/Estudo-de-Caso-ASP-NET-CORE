using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SisRh.Domain.Entities;
using SisRh.Domain.Interfaces.Services;
using SisRh.WEB.Models.Util;
using SisRh.WEB.Models.ViewModels;
using System.Collections.Generic;

namespace SisRh.WEB.Controllers
{
    public class EmpregadoController : ControllerConfig
    {
        private readonly IEmpregadoService _empregadoService;
        private readonly ISetorService _setorService;

        public EmpregadoController(IEmpregadoService empregadoService, ISetorService setorService, IMapper mapper)
            : base(mapper)
        {
            _empregadoService = empregadoService;
            _setorService = setorService;
        }

        private void DataLoading(EmpregadoViewModel model)
        {
            model.ListaSetores = new SelectList(_setorService.GetListToSelect(), "Value", "Text");
        }

        public IActionResult Index()
        {
            return View(this._mapper.Map<IEnumerable<EmpregadoViewModel>>(_empregadoService.GetAll()));
        }

        public IActionResult Create()
        {
            EmpregadoViewModel model = new EmpregadoViewModel();
            DataLoading(model);

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(EmpregadoViewModel model)
        {
            try
            {
                var domain = this._mapper.Map<Empregado>(model);

                if (ModelState.IsValid && _empregadoService.ValidarObjeto(domain))
                {
                    _empregadoService.Add(domain);

                    this.Sucesso = Resources.MensagemResource.MSG_REGISTRO_INSERIDO_SUCESSO;

                    return RedirectToAction("Index");

                }

                Funcoes.MontaMensagemErro(ModelState, _empregadoService.GetListaMensagensValidation());

                DataLoading(model);

                return View(model);
            }
            catch (System.Exception)
            {
                DataLoading(model);
                return View(model);
            }          
        }

        public IActionResult Edit(int id)
        {
            var model = this._mapper.Map<EmpregadoViewModel>(_empregadoService.GetById(id));
            DataLoading(model);

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, EmpregadoViewModel model)
        {
            try
            {
                model.Codigo = id;
                var domain = this._mapper.Map<Empregado>(model);

                if (ModelState.IsValid && _empregadoService.ValidarObjeto(domain))
                {
                    _empregadoService.Update(domain);

                    this.Sucesso = Resources.MensagemResource.MSG_REGISTRO_ATUALIZADO_SUCESSO;

                    return RedirectToAction("Index");
                }

                Funcoes.MontaMensagemErro(ModelState, _empregadoService.GetListaMensagensValidation());

                DataLoading(model);

                return View(model);
            }
            catch (System.Exception)
            {
                DataLoading(model);
                return View(model);
            }
        }

        public IActionResult Delete(int id)
        {
            return View(this._mapper.Map<EmpregadoViewModel>(_empregadoService.GetById(id)));
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            try
            {
                var model = _empregadoService.GetById(id);

                if (model != null)
                {
                    _empregadoService.Remove(model);

                    this.Sucesso = Resources.MensagemResource.MSG_REGISTRO_EXCLUIDO_SUCESSO;

                    return RedirectToAction("Index");
                }

                return RedirectToAction("Delete");
            }
            catch (System.Exception)
            {
                return RedirectToAction("Delete");
            }
        }
    }
}
