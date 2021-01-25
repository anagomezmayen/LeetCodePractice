using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice
{
	public class ListNode
	{
	  public int val;
	  public ListNode next;
	  public ListNode(int val = 0, ListNode next = null)
		{
			this.val = val;
			this.next = next;
				 }
  }
	class LinkedListPractice
	{
		/// <summary>
		/// You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order, and each of their nodes contains a single digit. Add the two numbers and return the sum as a linked list.
		///	You may assume the two numbers do not contain any leading zero, except the number 0 itself.
		/// </summary>
		/// <param name="l1"></param>
		/// <param name="l2"></param>
		/// <returns></returns>
		public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
		{
			ListNode result;
			int remanent = 0;
			int tempSum = 0;

			ListNode a = l1, b = l2;
			tempSum = a.val + b.val;
			if (tempSum >= 10)
			{
				result = new ListNode(tempSum % 10, null);
				remanent = 1;
			}
			else
			{
				result = new ListNode(tempSum, null);
			}

			ListNode r = result;
			a = a.next;
			b = b.next;

			while (a != null && b != null)
			{
				tempSum = a.val + b.val + remanent;

				if (tempSum >= 10)
				{
					r.next = new ListNode(tempSum % 10, null);
					remanent = tempSum / 10;
				}
				else
				{
					r.next = new ListNode(tempSum, null);
					remanent = 0;
				}
				a = a.next;
				b = b.next;
				r = r.next;

			}

			if (a == null && b != null)
			{
				while (b != null)
				{
					tempSum = b.val + remanent;
					if (tempSum >= 10)
					{
						r.next = new ListNode(tempSum % 10, null);
						remanent = tempSum / 10;
					}
					else
					{
						r.next = new ListNode(tempSum, null);
						remanent = 0;
					}
					b = b.next;
					r = r.next;
				}
			}

			if (b == null && a != null)
			{
				while (a != null)
				{
					tempSum = a.val + remanent;
					if (tempSum >= 10)
					{
						r.next = new ListNode(tempSum % 10, null);
						remanent = tempSum / 10;
					}
					else
					{
						r.next = new ListNode(tempSum, null);
						remanent = 0;
					}
					a = a.next;
					r = r.next;
				}

			}

			if (remanent > 0)
			{
				r.next = new ListNode(remanent, null);
			}
			return result;

		}

		static public ListNode MergeTwoLists(ListNode l1, ListNode l2)
		{
			if (l1 == null && l2 == null)
				return l1;
			if (l1 == null)
				return l2;
			if (l2 == null)
				return l1;

			ListNode a = l1, b = l2, x = null, result=null;

			if (b.val <= a.val)
			{
				x = b;
				b = b.next;

            }
            else
            {
				x = a;
				a = a.next;
            }

			result = x;

			Console.WriteLine(x.val);
			while (a!= null && b != null)
			{
				if (a.val <= b.val)
				{
					x.next = a;
					a = a.next;
					x = x.next;
				}
				else
				{
					x.next = b;
					b = b.next;
					x = x.next;
				}


			}

            if (a != null)
                x.next = a;
            if (b != null)
                x.next = b;

			return result;

		}

		static public void Main(string[] args)
        {
			ListNode l1 = new ListNode(2, null);
			//l1.next = new ListNode(2, new ListNode(4,null));

			ListNode l2 = new ListNode(-1, null);
			//l2.next = new ListNode(3, new ListNode(4, null));

			ListNode r=MergeTwoLists(l1, l2);

			while (r != null)
            {
				Console.Write(r.val + " -> ");
				r = r.next;
            }

		}
	}
}
