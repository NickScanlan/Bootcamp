function UnionArray(arr1 , arr2) {
    // Taking max element present in either array
    var m = arr1[arr1.length - 1];
    var n = arr2[arr2.length - 1];

    var ans = 0;

    if (m > n) {
        ans = m;
    } else
        ans = n;

    // Finding elements from 1st array
    // (non duplicates only). Using
    // another array for storing union
    // elements of both arrays
    // Assuming max element present
    // in array is not more than 10^7
    var newtable = Array(ans+1).fill(0);

    // First element is always
    // present in final answer
    document.write(arr1[0] + " ");

    // Incrementing the First element's count
    // in it's corresponding index in newtable
    newtable[arr1[0]]+=1;

    // Starting traversing the first
    // array from 1st index till last
    for (var i = 1; i < arr1.length; i++) {
        // Checking whether current element
        // is not equal to it's previous element
        if (arr1[i] != arr1[i - 1]) {
            document.write(arr1[i] + " ");
            newtable[arr1[i]]+= 1;
        }
    }

    // Finding only non common
    // elements from 2nd array
    for (var j = 0; j < arr2.length; j++) {
        // By checking whether it's already
        // present in newtable or not
        if (newtable[arr2[j]] == 0) {
            document.write(arr2[j] + " ");
            ++newtable[arr2[j]];
        }
    }
}

// Driver Code
    var arr1 = [ 1, 2, 2, 2, 3 ];
    var arr2 = [ 2, 3, 4, 5 ];

    UnionArray(arr1, arr2);