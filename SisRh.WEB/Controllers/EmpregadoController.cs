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
            if(ModelState.IsValid)
            {
                _empregadoService.Add(this._mapper.Map<Empregado>(model));

                this.Sucesso = Resources.MensagemResource.MSG_REGISTRO_INSERIDO_SUCESSO;

                return RedirectToAction("Index");
            }

            DataLoading(model);

            return View(model);
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
            model.Codigo = id;

            if(ModelState.IsValid)
            {
                _empregadoService.Update(this._mapper.Map<Empregado>(model));

                this.Sucesso = Resources.MensagemResource.MSG_REGISTRO_ATUALIZADO_SUCESSO;

                return RedirectToAction("Index");
            }

            DataLoading(model);

            return View(model);
        }

        public IActionResult Delete(int id)
        {
            return View(this._mapper.Map<EmpregadoViewModel>(_empregadoService.GetById(id)));
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var model = _empregadoService.GetById(id);

            if(model != null)
            {
                _empregadoService.Remove(model);

                this.Sucesso = Resources.MensagemResource.MSG_REGISTRO_EXCLUIDO_SUCESSO;

                return RedirectToAction("Index");
            }

            return RedirectToAction("Delete");
        }
    }
}
