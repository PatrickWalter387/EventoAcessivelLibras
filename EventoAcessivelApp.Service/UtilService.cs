using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventoAcessivelApp.Service
{
    public class UtilService
    {
        public async Task<string> SalvarArquivoLocalmente(IFormFile arquivo)
        {
            var diretorio = Directory.GetCurrentDirectory();
            var nomeArquivo = $"{DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond}-{arquivo.FileName}";
            var caminhoFinal = Path.Combine(diretorio, nomeArquivo);
            using (Stream fileStream = new FileStream(caminhoFinal, FileMode.Create))
            {
                await arquivo.CopyToAsync(fileStream);
            }

            return caminhoFinal;
        }
    }
}
