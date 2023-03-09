using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NguyenHaAnKhang_2090694884.Startup))]
namespace NguyenHaAnKhang_2090694884
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
