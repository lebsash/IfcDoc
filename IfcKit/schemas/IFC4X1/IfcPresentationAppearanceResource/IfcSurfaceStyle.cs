// This file was automatically generated from IFCDOC at www.buildingsmart-tech.org.
// IFC content is copyright (C) 1996-2018 BuildingSMART International Ltd.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;

using BuildingSmart.IFC.IfcMeasureResource;

namespace BuildingSmart.IFC.IfcPresentationAppearanceResource
{
	[Guid("359b755a-e87c-418d-bb14-8b2fd007e3ba")]
	public partial class IfcSurfaceStyle : IfcPresentationStyle,
		BuildingSmart.IFC.IfcPresentationAppearanceResource.IfcPresentationStyleSelect
	{
		[DataMember(Order=0)] 
		[XmlAttribute]
		[Required()]
		IfcSurfaceSide _Side;
	
		[DataMember(Order=1)] 
		[Required()]
		[MinLength(1)]
		[MaxLength(5)]
		ISet<IfcSurfaceStyleElementSelect> _Styles = new HashSet<IfcSurfaceStyleElementSelect>();
	
	
		public IfcSurfaceStyle()
		{
		}
	
		public IfcSurfaceStyle(IfcLabel? __Name, IfcSurfaceSide __Side, IfcSurfaceStyleElementSelect[] __Styles)
			: base(__Name)
		{
			this._Side = __Side;
			this._Styles = new HashSet<IfcSurfaceStyleElementSelect>(__Styles);
		}
	
		[Description("An indication of which side of the surface to apply the style.")]
		public IfcSurfaceSide Side { get { return this._Side; } set { this._Side = value;} }
	
		[Description("A collection of different surface styles.")]
		public ISet<IfcSurfaceStyleElementSelect> Styles { get { return this._Styles; } }
	
	
	}
	
}