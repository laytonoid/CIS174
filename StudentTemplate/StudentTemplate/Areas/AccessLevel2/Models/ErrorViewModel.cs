using Microsoft.AspNetCore.Mvc;

namespace StudentTemplate.Areas.AccessLevel2.Controllers
{
    [Area("AccessLevel2")]
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}