package md54cf07ad3cc6c5618f4d774c4862a6c21;


public class NoteAdapter_ButtonClickListener
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		android.view.View.OnClickListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onClick:(Landroid/view/View;)V:GetOnClick_Landroid_view_View_Handler:Android.Views.View/IOnClickListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"";
		mono.android.Runtime.register ("Week2.NoteAdapter+ButtonClickListener, Week2", NoteAdapter_ButtonClickListener.class, __md_methods);
	}


	public NoteAdapter_ButtonClickListener ()
	{
		super ();
		if (getClass () == NoteAdapter_ButtonClickListener.class)
			mono.android.TypeManager.Activate ("Week2.NoteAdapter+ButtonClickListener, Week2", "", this, new java.lang.Object[] {  });
	}

	public NoteAdapter_ButtonClickListener (android.app.Activity p0)
	{
		super ();
		if (getClass () == NoteAdapter_ButtonClickListener.class)
			mono.android.TypeManager.Activate ("Week2.NoteAdapter+ButtonClickListener, Week2", "Android.App.Activity, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public void onClick (android.view.View p0)
	{
		n_onClick (p0);
	}

	private native void n_onClick (android.view.View p0);

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
