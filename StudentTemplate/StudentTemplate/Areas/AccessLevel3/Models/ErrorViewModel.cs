using Microsoft.AspNetCore.Mvc;

namespace StudentTemplate.Areas.AccessLevel3.Controllers
{
    [Area("AccessLevel3")]
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}