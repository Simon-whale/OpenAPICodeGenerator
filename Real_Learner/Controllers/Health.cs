using Microsoft.AspNetCore.Mvc;

namespace Real_Learner.Controllers;

public class Health : ControllerBase
{
    public override async Task<ActionResult<bool>> GetHealth(CancellationToken cancellationToken = default(CancellationToken))
    {
        return true;
    }
}