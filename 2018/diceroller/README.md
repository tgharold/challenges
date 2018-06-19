
https://www.reddit.com/r/dailyprogrammer/comments/8s0cy1/20180618_challenge_364_easy_create_a_dice_roller/

Solution for dice roller that takes argument inputs, ignores anything that is not a die definition, and spits out the result.  Handles a maxmimum of `999d999`.

Example output:

```
$ dotnet run 3d6 4d8,12d10,,,
input: 3d6,4d8,12d10,,,
number of dice: 19
result: 91
```

Challenge output:

```
$ dotnet run 5d12 6d4 1d2 1d8 3d6 4d20 100d100
input: 5d12,6d4,1d2,1d8,3d6,4d20,100d100
number of dice: 120
result: 5042
```

# Technology stack

- .NET Core 2.1
- macOS
- Visual Studio Code
