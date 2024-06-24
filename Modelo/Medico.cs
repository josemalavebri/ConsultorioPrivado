namespace ConsultorioPrivado.Modelo
{
    public class Medico : IEntidad
    {
        private int id;
        private int cedula;
        private string nombre;
        private string apellido;
        private string correo;
        private int telefono;
        private int especialidad_id;

        public Medico()
        {
            id = 0;
            cedula = 0;
            nombre = string.Empty;
            apellido = string.Empty;
            Especialidad_id = 0;
            telefono = 0;
            correo = string.Empty;
        }

        public Medico(int id_medico, int cedula,
                      string nombre, string apellido,
                      int especialidad_id, string telefono,
                      string correo, string direccion)
        {
            this.id = id_medico;
            this.nombre = nombre;
            this.cedula = 0;
            this.apellido = apellido;
            this.Especialidad_id = especialidad_id;
            this.telefono = 0;
            this.correo = correo;
        }

        public int Id { get => id; set => id = value; }
        public int Cedula { get => cedula; set => cedula = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public string Correo { get => correo; set => correo = value; }
        public int Especialidad_id { get => especialidad_id; set => especialidad_id = value; }
    }
}
