namespace API.DTOs
{
    public class ContribuyenteToReturnDto
    {
        public int Id { get; set; }
        public string RncCedula { get; set; }
        public string Nombre { get; set; }
        public string TipoContribuyente { get; set; }
        public bool IsActivo { get; set; }

    }
}
