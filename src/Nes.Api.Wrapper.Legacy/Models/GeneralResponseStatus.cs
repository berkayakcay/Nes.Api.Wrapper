using System.ComponentModel.DataAnnotations;

namespace Nes.Api.Wrapper.Legacy.Models
{
    public class GeneralResponseStatus
    {
        [Required] 
        public int Code { get; set; }

        [Required] 
        public string Message { get; set; }
    }
}