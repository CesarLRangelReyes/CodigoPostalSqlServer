using System.Data.SqlClient;
using System.Data;

namespace CodigoPostalSqlServer
{
    public class BusquedasCP
    {
        private string estado;
        private string municipio;
        private string asentamiento;
        private int cp;

        SqlConnection conexion = new SqlConnection("server = DESKTOP-N1Q1432; database = CodigoPostal; integrated security = true");

        public string Estado { get => estado; set => estado = value; }
        public string Municipio { get => municipio; set => municipio = value; }
        public string Asentamiento { get => asentamiento; set => asentamiento = value; }
        public int Cp { get => cp; set => cp = value; }

        public DataTable CpEstado() {
            DataTable data = new DataTable();
            conexion.Open();
            SqlCommand cmd = new SqlCommand("Select Estado from Direcciones group by Estado Order by Estado asc",conexion);
            SqlDataAdapter leer = new SqlDataAdapter(cmd);
            leer.Fill(data);
            conexion.Close();
            DataRow fila = data.NewRow();
            fila["Estado"] = "--------SELECCIONAR ESTADO---------";
            data.Rows.InsertAt(fila, 0);
            return data;
        }

        public DataTable CpMunicipio() {
            DataTable data = new DataTable();
            conexion.Open();
            SqlCommand cmd = new SqlCommand("select Municipio from Direcciones where Estado = @estado group by Municipio order by Municipio asc",conexion);
            cmd.Parameters.AddWithValue("@estado",Estado);
            SqlDataAdapter leer = new SqlDataAdapter(cmd);
            leer.Fill(data);
            conexion.Close();
            DataRow fila = data.NewRow();
            fila["Municipio"] = "--------SELECCIONAR MUNICIPIO---------";
            data.Rows.InsertAt(fila, 0);
            return data;
        }

        public DataTable EstadoPorMunicipio() {
            DataTable data = new DataTable();
            conexion.Open();
            SqlCommand cmd = new SqlCommand("exec EM @estado,@municipio",conexion);
            cmd.Parameters.AddWithValue("@estado", Estado);
            cmd.Parameters.AddWithValue("@municipio", Municipio);
            SqlDataReader leer = cmd.ExecuteReader();
            if (leer.HasRows) data.Load(leer);
            leer.Close();
            conexion.Close();
            return data;
        }

        public DataTable CodigoPostal() {
            DataTable data = new DataTable();
            conexion.Open();
            SqlCommand cmd = new SqlCommand("exec CP @codigo",conexion);
            cmd.Parameters.AddWithValue("@codigo",Cp);
            SqlDataReader leer = cmd.ExecuteReader();
            if (leer.HasRows) data.Load(leer);
            leer.Close();
            conexion.Close();
            return data;
        }

        public DataTable MunicipioEstado() {
            DataTable data = new DataTable();
            conexion.Open();
            SqlCommand cmd = new SqlCommand("exec EMA @estado, @municipio, '%"+Asentamiento+"%'", conexion);
            cmd.Parameters.AddWithValue("@estado",Estado);
            cmd.Parameters.AddWithValue("@municipio",Municipio);
            SqlDataReader leer = cmd.ExecuteReader();
            if (leer.HasRows) data.Load(leer);
            leer.Close();
            conexion.Close();
            return data;
        }

        public DataTable CpAsentamiento()
        {
            DataTable data = new DataTable();
            conexion.Open();
            SqlCommand cmd = new SqlCommand("exec Asentamiento '%" + Asentamiento + "%'", conexion);
            SqlDataReader leer = cmd.ExecuteReader();
            if (leer.HasRows) data.Load(leer);
            leer.Close();
            conexion.Close();
            return data;
        }
    }
}
