Contains a few useful helpers methods, like string extensions. For exmaple, instead of clunky original way of validating the string:

```
if (string.IsNullOrEmpty(stringToCheck) == false) {
    // Do whatever needs to be done.
}
```

You may now write:

```
if (stringToCheck.IsNonEmpty()) {
    // Do whatever needs to be done.
}
```