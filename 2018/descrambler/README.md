# Descrambler

https://www.reddit.com/r/dailyprogrammer/comments/pkwgf/2112012_challenge_3_difficult/

For this challenge, you need to write a program that will take the scrambled words from this post, and compare them against [THIS WORD LIST](https://pastebin.com/jSD873gL) to unscramble them. For bonus points, sort the words by length when you are finished. Post your programs and/or subroutines!

Here are your words to de-scramble:

```
mkeart
sleewa
edcudls
iragoge
usrlsle
nalraoci
nsdeuto
amrhat
inknsy
iferkna
```

## Notes and Spoilers

- One possible approach is to sort the letters in both the words and the scrambles into alphabetical order.  Then just do a compare to find matches.  "mkeart" -> "aekmrt" is equal to "market" -> "aekmrt".  It's also possible that you get multiple matches.

