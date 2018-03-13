using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SisRh.Domain.Entities;
using SisRh.Domain.Interfaces.Services;
using SisRh.WEB.Models.Util;
using SisRh.WEB.Models.ViewModels;
using System.Collections.Generic;

namespace SisRh.WEB.Controllers
{
    public class SetorController : ControllerConfig
    {
        private readonly ISetorService _setorService;

        public SetorController(ISetorService setorService ,IMapper mapper)
            :base(mapper)
        {
            _setorService = setorService;
        }

        public IActionResult Index()
        {
            return View(this._mapper.Map<IEnumerable<SetorViewModel>>(_setorService.GetAll()));
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(SetorViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            _setorService.Add(this._mapper.Map<Setor>(model));

            if (_setorService.OperacaoValida())
            {
                this.Sucesso = Resources.MensagemResource.MSG_REGISTRO_INSERIDO_SUCESSO;
                return RedirectToAction("Index");
            }
            
            return View(model);
        }

        public IActionResult Edit(int id)
        {
            var model = this._mapper.Map<SetorViewModel>(_setorService.GetById(id));

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, SetorViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            model.Codigo = id;
            _setorService.Update(this._mapper.Map<Setor>(model));

            if (_setorService.OperacaoValida())
            {
                this.Sucesso = Resources.MensagemResource.MSG_REGISTRO_ATUALIZADO_SUCESSO;
                return RedirectToAction("Index");
            }

            return View(model);
        }

        public IActionResult Delete(int id)
        {
            return View(this._mapper.Map<SetorViewModel>(_setorService.GetById(id)));
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var model = _setorService.GetById(id);

            if (model != null)
            {
                _setorService.Remove(model);

                this.Sucesso = Resources.MensagemResource.MSG_REGISTRO_EXCLUIDO_SUCESSO;

                return RedirectToAction("Index");
            }

            return RedirectToAction("Delete");
        }
    }
}