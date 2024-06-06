namespace SalesWebMVC.Data
{
    public class SeedingService
    {
        private SalesWebMVCContext _context;
        public SeedingService(SalesWebMVCContext context) 
        { 
            _context = context; 
        }
    }
}
