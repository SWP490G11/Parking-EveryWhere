using Back_end.Entities;

namespace Back_end.Helper.Seeding
{
    public static class MembershipPagekageSeed
    {
        public static ICollection<MembershipPackage> Seed
        {
            get { return new List<MembershipPackage>() 
            
                {
                new MembershipPackage(){Name="Short",Discription="Short time",Price=40000,Months=1,LastModifyAt=DateTime.Now},
                new MembershipPackage(){Name="Medium",Discription="Half Year",Price=70000,Months=6,LastModifyAt=DateTime.Now},
                new MembershipPackage(){Name="Long",Discription="1 Year",Price=130000,Months=12,LastModifyAt=DateTime.Now},
                };
            }
        }
    }
}
