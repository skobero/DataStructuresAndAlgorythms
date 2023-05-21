# Algorithms

* ## **Linear Search**
	The simplest search algorithm.
	It goes through an entire array and check every value.
	O(n)

* ## **Binary Search**
	Important question to ask is the data set ordered.
	If the dataset is ordered I can jump forward and test if the value is equal or less or larger then.
	We half the array until we find the value.
	O(log(N))

	Pseudo Code:
	Search(array,low,high,needle)
		do{
			middle = low+(high-low)/2
			value = array[middle]
			If value == needle
				return true;
			elseif value > needle
				high = middle
			else
				low = middle + 1
	}while(low < high)

* ## **Two Crystal Ball Problem**
	Given two crystal ball that will break if dropped from high enough distance, 
	determine the exact spot in which it will break in the most optimized way.


	In general it is an array full of falses, that at some point it becomes true.
	We are trying to find where is this midpoint. 
	O(sqrt(N))
	We will jump inside the array by sqrt of N and the lineary walk back.

* ## **Bubble Sort**
	Start at the beginning.
	Checks if next position is larger. 
	If it is larger swap positions.
	After a first loop the last position has the largest value.
	Every next loop can be decreased by one.

	O(n*n)

* ## **Recursion**
	A function that calls itself until some base case is complete.

* ## **QuickSort**
	1. Choose a pivot element from the array. This can be done randomly, by selecting the middle element, or by using a different strategy.
	2. Partition the array such that all elements less than the pivot come before all elements greater than the pivot. This can be done by comparing each element to the pivot and moving elements to the left or right of the pivot accordingly.
	3. Recursively apply the same process to the sub-arrays on both sides of the pivot until the sub-arrays have at most one element (i.e., they are already sorted).
	4. Concatenate the sorted sub-arrays to obtain the final sorted array.

