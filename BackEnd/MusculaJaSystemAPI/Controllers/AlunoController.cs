using Microsoft.AspNetCore.Mvc;
using MusculaJaSystemAPI.Entities;

namespace MusculaJaSystemAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AlunoController : ControllerBase
    {

        //HttpPost - Criacao 
        //HttpGet - Obter 
        // HttpDelete - Deletar 
        // Httpput - Editar

        [HttpPost(Name = "CreateAluno")] 
        public string CreateAluno (Aluno objetoAluno)
        {

            return "devolvendo string";
        }

        [HttpGet(Name = "GetAlunoByName")]
        public Aluno GetAlunoByName(string NomeFrontend)
        {
            
            var objetoAluno = new Aluno();
            objetoAluno.Matricula = 1234;
            objetoAluno.Nome = "Marcelo";

            var objetoAluno2 = new Aluno();
            objetoAluno.Matricula = 123475;
            objetoAluno.Nome = "Theo";

            var objetoAluno3 = new Aluno();
            objetoAluno.Matricula = 123445;
            objetoAluno.Nome = "Tulio";

            if (NomeFrontend == objetoAluno.Nome)
            {
                return objetoAluno;
            }
            else if(NomeFrontend == objetoAluno2.Nome)
            {
                return objetoAluno2;
            }
            else if(NomeFrontend == objetoAluno3.Nome)
            {
                return objetoAluno3;
            }

          
        }
            //}

            //[HttpGet(Name = "GetAlunoByName")]
            //public ActionResult GetAlunoByName(string nome)
            //{
            //    var alunoObject = new Aluno();
            //    alunoObject.Nome = "Thiago";
            //    alunoObject.Matricula = 1234;

            //    var alunoObject2 = new Aluno();
            //    alunoObject.Nome = "Matheus";
            //    alunoObject.Matricula = 12345;

            //    if(alunoObject.Nome == nome)
            //    {
            //        return Ok(alunoObject);
            //    }
            //    else if (alunoObject2.Nome == nome)
            //    {
            //        return Ok(alunoObject);
            //    }
            //    else
            //    {
            //        return Ok("Náo foi possivel pesquisar por esse aluno ");
            //    }



            //}

        }

}
