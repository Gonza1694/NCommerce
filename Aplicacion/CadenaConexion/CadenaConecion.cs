namespace Aplicacion.CadenaConexion
{
    public static class CadenaConecion
    {
        // Atributos
        private const string Servidor = @"GON-PC\SQLEXPRESS";

        private const string BaseDatos = @"CommerceDbC4_Pais2";
        private const string Usuario = @"sa";
        private const string Password = @"1234";

        // Propiedad
        public static string ObtenerCadenaSql => $"Data Source={Servidor}; " +
                                                 $"Initial Catalog={BaseDatos}; " +
                                                 $"User Id={Usuario}; " +
                                                 $"Password={Password};";

        public static string ObtenerCadenaWin => $"Data Source={Servidor}; " +
                                                 $"Initial Catalog={BaseDatos}; " +
                                                 $"Integrated Security=true;";
    }
}