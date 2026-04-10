using GymApp.Models;
using GymApp.Repository;

namespace GymApp.Services
{
    public class MiembroService : IMiembroService
    {
        private readonly IMiembroRepository _repository;

        public MiembroService(IMiembroRepository repository)
        {
            _repository = repository;
        }

        public void Crear(Miembro miembro)
        {
            _repository.Add(miembro);
        }

        public List<Miembro> ObtenerTodos()
        {
            return _repository.GetAll();
        }

        public Miembro Buscar(string cedula)
        {
            return _repository.GetByCedula(cedula);
        }

        public void ActualizarTelefono(string cedula, string telefono)
        {
            _repository.UpdateTelefono(cedula, telefono);
        }

        public void Eliminar(string cedula)
        {
            _repository.Delete(cedula);
        }
    }
}
