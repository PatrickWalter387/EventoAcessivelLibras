using EventoAcessivelApp.Domain.Context;
using EventoAcessivelApp.Domain.Models;
using EventoAcessivelApp.Models;
using EventoAcessivelApp.Service;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EventoAcessivelApp.Controllers
{
    public class InterpreteController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UtilService _sUtil;

        public InterpreteController(AppDbContext context)
        {
            _context = context;
            _sUtil = new UtilService();
        }

        public IActionResult Form()
        {
            return View(new Interprete());
        }

        [HttpPost]
        public async Task<IActionResult> Form(Interprete form)
        {
            if(form.CurriculoFile is null)
                ModelState.AddModelError("CurriculoFile", "Campo 'Curriculo' obrigatório");

            if (form.FotoFile is null)
                ModelState.AddModelError("FotoFile", "Campo 'Foto' obrigatório");

            if (!ModelState.IsValid)
                return View(form);

            //salva o curriculo e foto localmente
            form.Curriculo = await _sUtil.SalvarArquivoLocalmente(form.CurriculoFile!);
            form.Foto = await _sUtil.SalvarArquivoLocalmente(form.FotoFile!);

            //insere-adiciona no banco via transacao
            _context.AddOrUpdate(form);

            //commita a transacao do banco
            _context.SaveChanges();

            return RedirectToAction("Form");
        }
    }
}