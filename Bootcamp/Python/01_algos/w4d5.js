/* 
  String Anagrams
  Given a string,
  return array where each element is a string representing a different anagram (a different sequence of the letters in that string).
  Ok to use built in methods
*/

const str1 = "lim";
const expected1 = ["ilm", "iml", "lim", "lmi", "mil", "mli"];
// Order of the output array does not matter

/**
 * Add params if needed for recursion.
 * Generates all anagrams of the given str.
 * - Time: O(?).
 * - Space: O(?).
 * @param {string} str
 * @returns {Array<string>} All anagrams of the given str.
 */
function generateAnagrams(str) { //don't be afraid to add parameters!
  //Your code here
    if(str.length <2)
        return str;

    out = []

    for(let i = 0; i < str.length; i++){
        let letter = str[i];
    }

    let remaining = str.slice(0, i) + str.slice(i + 1, str.length);

    for(let sub of generateAnagrams(remaining)
        



    

}

console.log(generateAnagrams(str1)) //["ilm", "iml", "lim", "lmi", "mil", "mli"] (order may vary, that's okay)