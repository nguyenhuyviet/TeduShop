using System;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.Owin;
using Owin;
using TeduShop.Model.Models;
using TeduShop.Web.Models;

namespace TeduShop.Web.Mappings
{
    public class AutoMapperWebProfile : Profile
    {
        public AutoMapperWebProfile()
        {
            CreateMap<Post, PostViewModel>();
            CreateMap<PostCategory, PostCategoryViewModel>();
            CreateMap<Tag, TagViewModel>();
            CreateMap<ProductCategory, ProductCategoryViewModel>();
            CreateMap<Product, ProductViewModel>();
            CreateMap<ProductTag, ProductTagViewModel>();
            CreateMap<Footer, FooterViewModel>();
            CreateMap<Slide, SlideViewModel>();
            CreateMap<Page, PageViewModel>();
            //CreateMap<ContactDetail, ContactDetailViewModel>();
            //CreateMap<ApplicationGroup, ApplicationGroupViewModel>();
            //CreateMap<ApplicationRole, ApplicationRoleViewModel>();
            //CreateMap<ApplicationUser, ApplicationUserViewModel>();
        }

        public static void Run()
        {
            AutoMapper.Mapper.Initialize(a =>
            {
                a.AddProfile<AutoMapperWebProfile>();


            });
        }
    }
}
