---
title: REPL Commands
---

REPL is the shipped command line interface to interact with ResoniteLink.  
Pre-built binaries are currently not shipped, however, its code is under the same license and repository as ResoniteLink.

It is provided as a proof-of-concept interface for ResoniteLink. Feel free to expand on it.

It implements several commands, which are case-insensitive:

| Command           | Arguments                                                | Description                                                         |
|-------------------|----------------------------------------------------------|---------------------------------------------------------------------|
| `echo`            | `string`: message                                        | Will just print again what you sent.                                |
| `listChildren`    |                                                          | Lists all the children under the selected slot.                     |
| `listComponents`  |                                                          | Lists all the components under the selected slot.                   |
| `selectChild`     | `int`: index of the child                                | Selects a child slot from its index number.                         |
| `selectComponent` | `int`: index of the component                            | Selects a component from its index number                           |
| `clearcomponent`  |                                                          | Removes the component.                                              |
| `componentState`  |                                                          | Lists the fields of the components and their values.                |
| `addcomponent`    | `string`: component ID                                   | Adds a component to the selected slot.                              |
| `addchild`        | `string`: name                                           | Adds a child slot to the selected slot.                             |
| `removeslot`      |                                                          | Removes the currently selected slot.                                |
| `removecomponent` | `int`: index (optional if component selected)            | Removes that component from the slot.                               |
| `selectparent`    |                                                          | Selects the parent slot from which you are on.                      |
| `set`             | `string`: component field name<br/>`string/JSON`: values | Sets the values for the specified fields on the selected component. |
| `exit`            |                                                          | Exits REPL.                                                         |
