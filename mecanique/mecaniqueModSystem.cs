using Vintagestory.API.Common;

namespace mecanique;

public class mecaniqueModSystem : ModSystem
{
  // Called on server and client
  public override void Start(ICoreAPI api)
  {
    api.Logger.Notification("Hello from template mod: " + Lang.Get("mymodid:hello"));
  }

  public override void StartServerSide(ICoreServerAPI api)
  {
    api.Logger.Notification("Hello from template mod server side");
  }

  public override void StartClientSide(ICoreClientAPI api)
  {
    api.Logger.Notification("Hello from template mod client side");
  }
}
