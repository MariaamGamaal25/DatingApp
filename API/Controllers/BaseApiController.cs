using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{

[ApiController]
[Route("api/[controller]")]  //address: /api/users (route le user tabel)(we da framework talama bnt3amel ma3a http request)
//framework hyshof el controller we ba3d kda constructor fa elframework yfham eny 3ayza data context fa hy3mel new instance of the data context we ydakhalo m3ana we ykon available lena


public class BaseApiController : ControllerBase
{

}

}
