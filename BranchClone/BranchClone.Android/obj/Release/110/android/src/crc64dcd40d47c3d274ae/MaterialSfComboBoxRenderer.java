package crc64dcd40d47c3d274ae;


public class MaterialSfComboBoxRenderer
	extends crc64dcd40d47c3d274ae.SfComboBoxRenderer
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Syncfusion.XForms.Android.ComboBox.MaterialSfComboBoxRenderer, Syncfusion.SfComboBox.XForms.Android", MaterialSfComboBoxRenderer.class, __md_methods);
	}


	public MaterialSfComboBoxRenderer (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == MaterialSfComboBoxRenderer.class)
			mono.android.TypeManager.Activate ("Syncfusion.XForms.Android.ComboBox.MaterialSfComboBoxRenderer, Syncfusion.SfComboBox.XForms.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public MaterialSfComboBoxRenderer (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == MaterialSfComboBoxRenderer.class)
			mono.android.TypeManager.Activate ("Syncfusion.XForms.Android.ComboBox.MaterialSfComboBoxRenderer, Syncfusion.SfComboBox.XForms.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public MaterialSfComboBoxRenderer (android.content.Context p0)
	{
		super (p0);
		if (getClass () == MaterialSfComboBoxRenderer.class)
			mono.android.TypeManager.Activate ("Syncfusion.XForms.Android.ComboBox.MaterialSfComboBoxRenderer, Syncfusion.SfComboBox.XForms.Android", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
