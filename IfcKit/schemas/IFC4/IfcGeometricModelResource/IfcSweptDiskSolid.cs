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

using BuildingSmart.IFC.IfcGeometryResource;
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcPresentationAppearanceResource;
using BuildingSmart.IFC.IfcProfileResource;
using BuildingSmart.IFC.IfcTopologyResource;

namespace BuildingSmart.IFC.IfcGeometricModelResource
{
	[Guid("4140e5e6-6e10-487d-80b0-738ba2b7bedb")]
	public partial class IfcSweptDiskSolid : IfcSolidModel
	{
		[DataMember(Order=0)] 
		[XmlElement("IfcCurve")]
		[Required()]
		IfcCurve _Directrix;
	
		[DataMember(Order=1)] 
		[XmlAttribute]
		[Required()]
		IfcPositiveLengthMeasure _Radius;
	
		[DataMember(Order=2)] 
		[XmlAttribute]
		IfcPositiveLengthMeasure? _InnerRadius;
	
		[DataMember(Order=3)] 
		[XmlAttribute]
		IfcParameterValue? _StartParam;
	
		[DataMember(Order=4)] 
		[XmlAttribute]
		IfcParameterValue? _EndParam;
	
	
		[Description("The curve used to define the sweeping operation. The solid is generated by sweepi" +
	    "ng a circular disk along the <em>Directrix</em>.")]
		public IfcCurve Directrix { get { return this._Directrix; } set { this._Directrix = value;} }
	
		[Description("The <em>Radius</em> of the circular disk to be swept along the <em>directrix</em>" +
	    ". Denotes the outer radius, if an <em>InnerRadius</em> is applied.")]
		public IfcPositiveLengthMeasure Radius { get { return this._Radius; } set { this._Radius = value;} }
	
		[Description("This attribute is optional, if present it defines the radius of a circular hole i" +
	    "n the centre of the disk.")]
		public IfcPositiveLengthMeasure? InnerRadius { get { return this._InnerRadius; } set { this._InnerRadius = value;} }
	
		[Description(@"The parameter value on the <em>Directrix</em> at which the sweeping operation commences. <font color=""#0000ff"">If no value is provided the start of the sweeping operation is at the start of the <em>Directrix</em>.</font>.
	<blockquote class=""change-ifc2x4"">IFC4 CHANGE&nbsp; The attribute has been changed to OPTIONAL with upward compatibility for file-based exchange.</blockquote>")]
		public IfcParameterValue? StartParam { get { return this._StartParam; } set { this._StartParam = value;} }
	
		[Description(@"The parameter value on the <em>Directrix</em> at which the sweeping operation ends. <font color=""#0000ff"">If no value is provided the end of the sweeping operation is at the end of the <em>Directrix</em>.</font>.
	<blockquote class=""change-ifc2x4"">IFC4 CHANGE&nbsp; The attribute has been changed to OPTIONAL with upward compatibility for file-based exchange.</blockquote>")]
		public IfcParameterValue? EndParam { get { return this._EndParam; } set { this._EndParam = value;} }
	
	
	}
	
}