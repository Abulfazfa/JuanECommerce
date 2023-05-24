namespace JuanFrontToBack
{
    public static class ServiceRegistration
    {
        public static void ServiceRegister(this IServiceCollection services)
        {
            services.AddControllersWithViews();
        }
    }
}
