namespace Nes.Api.Wrapper.Legacy.Models
{
    public class GeneralResponse<T>
    {
        public GeneralResponseStatus ErrorStatus { get; set; }
        public T Result { get; set; }
    }
}