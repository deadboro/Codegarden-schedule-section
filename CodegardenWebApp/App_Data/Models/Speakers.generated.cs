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
	/// <summary>Speakers</summary>
	[PublishedContentModel("speakers")]
	public partial class Speakers : PublishedContentModel, IContentPage, IMenu, ISEO
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "speakers";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Speakers(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Speakers, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
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
		/// Menu description
		///</summary>
		[ImplementPropertyType("menuDescription")]
		public string MenuDescription
		{
			get { return Umbraco.Web.PublishedContentModels.Menu.GetMenuDescription(this); }
		}

		///<summary>
		/// Menu title
		///</summary>
		[ImplementPropertyType("menuTitle")]
		public string MenuTitle
		{
			get { return Umbraco.Web.PublishedContentModels.Menu.GetMenuTitle(this); }
		}

		///<summary>
		/// Hide from nav?
		///</summary>
		[ImplementPropertyType("umbracoNaviHide")]
		public bool UmbracoNaviHide
		{
			get { return Umbraco.Web.PublishedContentModels.Menu.GetUmbracoNaviHide(this); }
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
