Data acquisition application for the USB-MEA256-System by Multi Channel Systems GmbH.

### TODO

- [ ] Load balancing (backup background worker v.s. broadcast background worker).
- [ ] Clean GUI.
- [ ] Trigger backup and broadcast when a TCP connection is accepted.
- [ ] Handle exceptions.
- [ ] Send analog data only (discard digital, checksum and timestamp channels).
- [ ] Check if the broadcast buffer can get full and find why.
- [ ] ...