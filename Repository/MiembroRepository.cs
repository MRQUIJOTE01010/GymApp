using GymApp.Models;
using GymApp.Database;

namespace GymApp.Repository
{
    public class MiembroRepository : IMiembroRepository
    {
        private readonly GymDbContext _context;

        public MiembroRepository(GymDbContext context)
        {
            _context = context;
        }

        public void Add(Miembro miembro)
        {
            _context.Miembros.Add(miembro);
            _context.SaveChanges();
        }

        public List<Miembro> GetAll()
        {
            return _context.Miembros.ToList();
        }

        public Miembro GetByCedula(string cedula)
        {
            return _context.Miembros
                .FirstOrDefault(m => m.Cedula == cedula);
        }

        public void UpdateTelefono(string cedula, string telefono)
        {
            var miembro = _context.Miembros
                .FirstOrDefault(m => m.Cedula == cedula);

            if (miembro != null)
            {
                miembro.Telefono = telefono;
                _context.SaveChanges();
            }
        }

        public void Delete(string cedula)
        {
            var miembro = _context.Miembros
                .FirstOrDefault(m => m.Cedula == cedula);

            if (miembro != null)
            {
                _context.Miembros.Remove(miembro);
                _context.SaveChanges();
            }
        }
    }
}

