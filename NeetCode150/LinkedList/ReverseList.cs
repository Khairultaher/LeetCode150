﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeetCode150.LinkedList;

//Definition for singly-linked list.
public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null!) {
        this.val = val;
        this.next = next;
    }
}

public partial class Solution
{
    public ListNode ReverseList(ListNode head) {
        ListNode prev = null!, curr = head;

        while (curr != null) {
            var temp = curr.next;
            curr.next = prev;
            prev = curr;
            curr = temp;
        }
        return prev;
    }
}

