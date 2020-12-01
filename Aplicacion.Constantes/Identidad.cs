namespace Aplicacion.Constantes
{
    public static class Identidad
    {

        public static long EmpleadoId { get; set; }
        public static bool EsAdmin { get; set; }
        public static string Apellido { get; set; }

        public static string Nombre { get; set; }

        public static long UsuarioId { get; set; }

        public static string Usuario { get; set; }

        public static byte[] Foto { get; set; }

        public static void Limpiar()
        {
            EmpleadoId = -1;
            EsAdmin = false;
            Apellido = string.Empty;
            Nombre = string.Empty;
            UsuarioId = -1;
            Usuario = string.Empty;
            Foto = null;
        }
    }
}