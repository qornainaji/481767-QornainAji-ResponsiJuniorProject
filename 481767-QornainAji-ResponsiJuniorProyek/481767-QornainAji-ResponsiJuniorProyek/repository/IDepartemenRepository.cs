using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql

namespace _481767_QornainAji_ResponsiJuniorProyek.repository
{
    public interface IDepartemenRepository
    {
        List<Departemen>GetAll();
    }

    public class DepartemenRepository:IDepartemenRepository 
    {
        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=5432;Username=postgres;Password=informatika;Database=responsi";
    }
}
