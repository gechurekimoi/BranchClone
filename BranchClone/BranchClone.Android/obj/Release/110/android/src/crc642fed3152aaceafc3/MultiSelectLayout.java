package crc642fed3152aaceafc3;


public class MultiSelectLayout
	extends android.widget.LinearLayout
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_dispatchTouchEvent:(Landroid/view/MotionEvent;)Z:GetDispatchTouchEvent_Landroid_view_MotionEvent_Handler\n" +
			"";
		mono.android.Runtime.register ("Syncfusion.Android.ComboBox.MultiSelectLayout, Syncfusion.SfComboBox.XForms.Android", MultiSelectLayout.class, __md_methods);
	}


	public MultiSelectLayout (android.content.Context p0)
	{
		super (p0);
		if (getClass () == MultiSelectLayout.class)
			mono.android.TypeManager.Activate ("Syncfusion.Android.ComboBox.MultiSelectLayout, Syncfusion.SfComboBox.XForms.Android", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public MultiSelectLayout (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == MultiSelectLayout.class)
			mono.android.TypeManager.Activate ("Syncfusion.Android.ComboBox.MultiSelectLayout, Syncfusion.SfComboBox.XForms.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public MultiSelectLayout (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == MultiSelectLayout.class)
			mono.android.TypeManager.Activate ("Syncfusion.Android.ComboBox.MultiSelectLayout, Syncfusion.SfComboBox.XForms.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public boolean dispatchTouchEvent (android.view.MotionEvent p0)
	{
		return n_dispatchTouchEvent (p0);
	}

	private native boolean n_dispatchTouchEvent (android.view.MotionEvent p0);

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
