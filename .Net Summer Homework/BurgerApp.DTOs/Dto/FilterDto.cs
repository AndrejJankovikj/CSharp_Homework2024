namespace BurgerApp.DTOs.Dto
{
    public class FilterDto
    {
        public List<BurgerDto> Burgers { get; set; }
        public List<OrderDto> Orders { get; set; }
        public int BurgerId { get; set; } = 0;
        public int OrderId { get; set; } = 0;

    }
}
