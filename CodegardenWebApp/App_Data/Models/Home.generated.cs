//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.7.99
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder;
using Umbraco.ModelsBuilder.Umbraco;

namespace Umbraco.Web.PublishedContentModels
{
	/// <summary>Home</summary>
	[PublishedContentModel("home")]
	public partial class Home : PublishedContentModel, IContentPage, IFrontpage, ISEO
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "home";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Home(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Home, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Company name
		///</summary>
		[ImplementPropertyType("companyName")]
		public string CompanyName
		{
			get { return this.GetPropertyValue<string>("companyName"); }
		}

		///<summary>
		/// Facebook link: Link to Facebook account (Optional)
		///</summary>
		[ImplementPropertyType("facebookLink")]
		public string FacebookLink
		{
			get { return this.GetPropertyValue<string>("facebookLink"); }
		}

		///<summary>
		/// Footer text
		///</summary>
		[ImplementPropertyType("footerText")]
		public string FooterText
		{
			get { return this.GetPropertyValue<string>("footerText"); }
		}

		///<summary>
		/// Linkedin link: Link to Linkedin account (Optional)
		///</summary>
		[ImplementPropertyType("linkedinLink")]
		public string LinkedinLink
		{
			get { return this.GetPropertyValue<string>("linkedinLink"); }
		}

		///<summary>
		/// Twitter link: Link to Twitter account (Optional)
		///</summary>
		[ImplementPropertyType("twitterLink")]
		public string TwitterLink
		{
			get { return this.GetPropertyValue<string>("twitterLink"); }
		}

		///<summary>
		/// Website name
		///</summary>
		[ImplementPropertyType("websiteName")]
		public string WebsiteName
		{
			get { return this.GetPropertyValue<string>("websiteName"); }
		}

		///<summary>
		/// Body text
		///</summary>
		[ImplementPropertyType("bodyText")]
		public IHtmlString BodyText
		{
			get { return Umbraco.Web.PublishedContentModels.ContentPage.GetBodyText(this); }
		}

		///<summary>
		/// Headline
		///</summary>
		[ImplementPropertyType("headline")]
		public string Headline
		{
			get { return Umbraco.Web.PublishedContentModels.ContentPage.GetHeadline(this); }
		}

		///<summary>
		/// Banner image
		///</summary>
		[ImplementPropertyType("bannerImage")]
		public Umbraco.Web.Models.ImageCropDataSet BannerImage
		{
			get { return Umbraco.Web.PublishedContentModels.Frontpage.GetBannerImage(this); }
		}

		///<summary>
		/// Countdown
		///</summary>
		[ImplementPropertyType("countdown")]
		public DateTime Countdown
		{
			get { return Umbraco.Web.PublishedContentModels.Frontpage.GetCountdown(this); }
		}

		///<summary>
		/// Meta description
		///</summary>
		[ImplementPropertyType("metaDescription")]
		public string MetaDescription
		{
			get { return Umbraco.Web.PublishedContentModels.SEO.GetMetaDescription(this); }
		}

		///<summary>
		/// Meta title
		///</summary>
		[ImplementPropertyType("metaTitle")]
		public string MetaTitle
		{
			get { return Umbraco.Web.PublishedContentModels.SEO.GetMetaTitle(this); }
		}
	}
}
