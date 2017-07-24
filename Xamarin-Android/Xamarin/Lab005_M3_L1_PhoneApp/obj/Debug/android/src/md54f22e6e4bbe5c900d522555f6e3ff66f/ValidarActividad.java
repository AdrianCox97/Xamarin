package md54f22e6e4bbe5c900d522555f6e3ff66f;


public class ValidarActividad
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("Lab005_M3_L1_PhoneApp.ValidarActividad, Lab005_M3_L1_PhoneApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", ValidarActividad.class, __md_methods);
	}


	public ValidarActividad () throws java.lang.Throwable
	{
		super ();
		if (getClass () == ValidarActividad.class)
			mono.android.TypeManager.Activate ("Lab005_M3_L1_PhoneApp.ValidarActividad, Lab005_M3_L1_PhoneApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

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
