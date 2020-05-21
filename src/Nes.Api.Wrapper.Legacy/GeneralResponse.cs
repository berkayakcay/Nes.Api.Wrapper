using System.ComponentModel.DataAnnotations;

namespace Nes.Api.Wrapper.Legacy
{
    public class GeneralResponse<T>
    {
        public GeneralResponseStatus ErrorStatus { get; set; }
        public T Result { get; set; }
    }

    public class GeneralResponseStatus
    {
        [Required] public int Code { get; set; }

        [Required] public string Message { get; set; }
    }
}