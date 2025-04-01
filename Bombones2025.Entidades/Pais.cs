namespace Bombones2025.Entidades
{
    public class Pais//aca le cambie el nombre de la clase, y siempre va en singular
    {
        public int PaisId { get; set; }
        public string NombrePais { get; set; } = null!;

        public override string ToString()
        {
            return $"{NombrePais}";
        }
    }
}
