using System.Collections.Generic;

public class EchoLinkedList
{
	public delegate void CreateNewObject();

	public static List<EchoLinkedList> active_firstList;

	public static List<EchoLinkedList> active_lastList;

	public static List<EchoLinkedList> inactive_firstList;

	public static List<EchoLinkedList> inactive_lastList;

	public static List<EchoListCallback> newObjCallbacks;

	public static int echoPoolListCount;

	public EchoLinkedList active_last;

	public EchoLinkedList inactive_last;

	public EchoLinkedList active_next;

	public EchoLinkedList active_prev;

	public EchoLinkedList inactive_next;

	public EchoLinkedList inactive_prev;

	public static int PoolListAdd()
	{
		return 0;
	}

	public void PoolListItemInit(int ipoolListID)
	{
	}

	public static void NewObjectCallback(int ipoolListID, EchoListCallback.CreateNewObject icallback)
	{
	}

	public static EchoLinkedList PoolGetFirstActive(int ipoolListID)
	{
		return null;
	}

	public static EchoLinkedList PoolGetLastActive(int ipoolListID)
	{
		return null;
	}

	public static EchoLinkedList PoolGetFirstInactive(int ipoolListID)
	{
		return null;
	}

	public static EchoLinkedList PoolGetLastInactive(int ipoolListID)
	{
		return null;
	}

	public static EchoLinkedList PoolGetFreeInactive(int ipoolListID)
	{
		return null;
	}

	public static void PoolAddListInactive(EchoLinkedList epl)
	{
	}

	public static void PoolRemoveListInactive(EchoLinkedList epl)
	{
	}

	public static void PoolAddListActive(EchoLinkedList epl)
	{
	}

	public static void PoolRemoveListActive(EchoLinkedList epl)
	{
	}

	public static void PoolMoveActive2Inactive(EchoLinkedList epl)
	{
	}

	public static void PoolMoveInactive2Active(EchoLinkedList epl)
	{
	}

	public virtual void ProcessInUpdate()
	{
	}
}
