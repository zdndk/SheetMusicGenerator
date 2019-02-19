This program implements a DSL in the form of a fluent API for music sheets. The structure is as follows:

A sheet can have multiple bars. A bar can have multiple nodes.

The handling of the fluent API is implemented in the SheetMusicGenerator.Domain project. The API exposes 2 sets of interfaces: One for external consumers, and one for internal use. The version prevents the consumer from corrupting internal state variables by not exposing them. The fluent API makes use of an extended interface, exposing access to the internal state variables.

In the SheetMusicGenerator project ( in the Program.CS file ), the API is used by entering "Mary had a little lamb" into the modelbuilder system. In the end, the build method is called, and the model is returned. The user is then able to shift the pitch of the nodes, by entering + and - into the console interface. The model is manipulated by the Pitchshifter class, and printed.

A compiled version of the program is found in the root ( SheetMusicGenerator.exe )

PS) The implementation is very simple, and does not take things like half-steps and scales into account.