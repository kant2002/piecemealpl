param(
	$Experiment,
	[switch]
	$Clean,
	[switch]
	$Format
)
function Build-Folder($folder)
{
	echo "===== Building $folder ====="
	pushd $folder
	cd rust
	cargo build -r
	cd ../c
	if (Test-Path "vcpkg.json") {
		cmake -S. -Bbuild -DCMAKE_TOOLCHAIN_FILE="$env:VCPKG_ROOT/scripts/buildsystems/vcpkg.cmake" -DVCPKG_TARGET_TRIPLET=x64-windows-static
	} else {
		cmake -S. -Bbuild
	}
	
	cmake --build build --config Release
	cd ../naot
	dotnet publish
	cd ../go
	go mod tidy
	go build -o out/ -ldflags "-s -w"
	cd ..
	popd
}

function Clean-Folder($folder)
{
	echo "===== Cleaning $folder ====="
	pushd $folder
	cd rust
	cargo clean
	cd ../c
	if (Test-Path "build") {
		rm -r build -force
	}
	cd ../naot
	if (Test-Path "bin") {
		rm -r bin
	}
	if (Test-Path "obj") {
		rm -r obj
	}
	if (Test-Path ".vs") {
		rm -r .vs -force
	}
	cd ../go
	if (Test-Path "out") {
		rm -r out
	}
	cd ..
	popd
}

function Format-Folder($folder)
{
	echo "===== Cleaning $folder ====="
	pushd $folder
	cd rust
	cargo fmt
	cd ../c
	cd ../naot
	cd ../go
	go fmt main.go
	cd ..
	popd
}

function Measure-Folder($folder)
{
	ls $folder/c/build/Release/$folder.exe | Select-Object Name, Length
	ls $folder/rust/target/release/$folder.exe | Select-Object Name, Length
	ls $folder/naot/bin/Release/net10.0/win-x64/publish/$folder.exe | Select-Object Name, Length
	ls $folder/go/out/$folder.exe | Select-Object Name, Length
}

if (-not $env:VCPKG_ROOT) {
	$env:VCPKG_ROOT = "C:\Program Files\Microsoft Visual Studio\2022\Preview\VC\vcpkg"
}

$experiments = @("baseline", "sum_strings", "parse_float", "strreverse", "tolower", "strempty", "arrayinit", "cmdlineargs",
	"readfile", "archivefile", "createfile", 
	#"sdl2", # Go and Rust version does not compiled
	"win32_window", "win32_button")
if ($Experiment) {
		$experiments = @($Experiment)
}
#$experiments = @("createfile")
if ($Clean)
{
	foreach ($experiment in $experiments) {
		Clean-Folder $experiment
	}
}
elseif ($Format)
{
	foreach ($experiment in $experiments) {
		Format-Folder $experiment
	}
}
else
{
	foreach ($experiment in $experiments) {
		Build-Folder $experiment
	}

	foreach ($experiment in $experiments) {
		Measure-Folder $experiment
	}
}