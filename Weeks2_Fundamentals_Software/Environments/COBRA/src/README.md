# Simple Client/Server over COBRA

COBRA is a technology for sharing objects over the network.

## How do I launch this application

```PowerShell
$> devenv.bat
$> orbd -ORBInitialPort 1050&
$> ./build.sh
$> java HelloServer -ORBInitialPort 1050 -ORBInitialHost localhost&
$> java HelloClient -ORBInitialPort 1050 -ORBInitialHost localhost
```

## How do I make changes to it

1. Update the [Hello.idl](Hello.idl) file
2. Rerun [build.sh](build.sh) from within the [Dockerfile](Dockerfile)
3. Kill/Start the Server process
4. Run the client to execute in the remote process
