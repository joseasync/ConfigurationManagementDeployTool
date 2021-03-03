namespace CMDT.Domain.Utils
{
    public static class RoutesManagement{
        public const string Root = "api";
        public const string Version = "v1";
        public const string Base = Root + "/" + Version;
        
         public static class Tag
        {
            public const string GetTag = Base + "/tag";
            public const string GetTagById = Base + "/tag/{id}";
        }

    }    
}