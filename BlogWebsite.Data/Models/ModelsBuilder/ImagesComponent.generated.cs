//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v9.1.1+b58a0cf0a5b3b695f09b8884a704d2264b32e253
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Linq.Expressions;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.PublishedCache;
using Umbraco.Cms.Infrastructure.ModelsBuilder;
using Umbraco.Cms.Core;
using Umbraco.Extensions;

namespace BlogWebsite.Data.Models.ModelsBuilder
{
	/// <summary>Afbeelding(en)</summary>
	[PublishedModel("imagesComponent")]
	public partial class ImagesComponent : PublishedElementModel, IComponentComposition
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.1.1+b58a0cf0a5b3b695f09b8884a704d2264b32e253")]
		public new const string ModelTypeAlias = "imagesComponent";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.1.1+b58a0cf0a5b3b695f09b8884a704d2264b32e253")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.1.1+b58a0cf0a5b3b695f09b8884a704d2264b32e253")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.1.1+b58a0cf0a5b3b695f09b8884a704d2264b32e253")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<ImagesComponent, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public ImagesComponent(IPublishedElement content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// Afbeelding(en): Voeg ????n of meerdere afbeeldingen toe.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.1.1+b58a0cf0a5b3b695f09b8884a704d2264b32e253")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("images")]
		public virtual global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Core.Models.MediaWithCrops> Images => this.Value<global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Core.Models.MediaWithCrops>>(_publishedValueFallback, "images");

		///<summary>
		/// Actief: Geef aan of dit component actief moet zijn.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.1.1+b58a0cf0a5b3b695f09b8884a704d2264b32e253")]
		[ImplementPropertyType("active")]
		public virtual bool Active => global::BlogWebsite.Data.Models.ModelsBuilder.ComponentComposition.GetActive(this, _publishedValueFallback);

		///<summary>
		/// Anchor: Optioneel. Gebruik dit veld om een anchorpunt op dit component toe te voegen. Vanuit een link kan met behulp van de #-notatie worden verwezen naar dit component. Moet uniek zijn op een pagina.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.1.1+b58a0cf0a5b3b695f09b8884a704d2264b32e253")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("anchor")]
		public virtual string Anchor => global::BlogWebsite.Data.Models.ModelsBuilder.ComponentComposition.GetAnchor(this, _publishedValueFallback);
	}
}
