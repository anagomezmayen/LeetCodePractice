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
	}
}
