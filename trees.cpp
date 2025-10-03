#include<bits/stdc++.h>
using namespace std;

class SegTree{
    vector<int> tree;
    int n;

    public:
        SegTree(vector<int>& arr)
        {
            n = arr.size();
            tree.resize(4*n, 0);
            build(1, 0, n-1, arr);
        }

        int check(int a, int b)
        {
            return a+b;
        }

        void build(int index, int low, int high, vector<int>& arr)
        {
            if(low==high)
            {
                tree[index] = arr[low];
                return;
            }

            int mid = (low+high)/2;
            build(2*index, low, mid, arr);
            build(2*index+1, mid+1, high, arr);
            tree[index] = check(tree[2*index], tree[2*index+1]);
        }

        void update(int index, int val, int low, int high, int val_index)
        {
            if(low==high)
            {
                tree[index] = val;
                return;
            }

            int mid = (low+high)/2;
            if(val_index<=mid)
            {
                update(2*index, val, low, mid, val_index);
            }
            else
            {
                update(2*index+1, val, mid+1, high, val_index);
            }
            tree[index] = check(tree[2*index], tree[2*index+1]);
        }

        
}
