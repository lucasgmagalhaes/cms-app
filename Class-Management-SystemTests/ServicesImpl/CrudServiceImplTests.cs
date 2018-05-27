using Microsoft.VisualStudio.TestTools.UnitTesting;
using Class_Management_System.Services;
using Class_Management_System.Entities;
using Class_Management_System.Utils;

namespace Class_Management_System.ServicesImpl.Tests
{
    [TestClass()]
    public class CrudServiceImplTests
    {
        private Professor professor;
        private Disciplina disciplina;
        private Aula aula;
        private ICrudService<Aula> crudService;
        public CrudServiceImplTests()
        {
            this.professor = new Professor("professor");
            this.disciplina = new Disciplina("disciplina", Enums.Periodo.PRIMEIRO, professor);
            this.aula = new Aula(this.professor, this.disciplina, 2);
            this.crudService = DependencyFactory.Resolve<ICrudService<Aula>>();
        }

        [TestMethod()]
        public void findTest()
        {
            Assert.IsNull(this.crudService.find(this.aula));   
        }
    }
}