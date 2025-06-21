cmake_minimum_required(VERSION 3.10)
project(createdir2 C)

file(GLOB sources      main.c)

add_compile_options("$<$<NOT:$<CONFIG:Debug>>:/Zi>")
add_link_options("$<$<NOT:$<CONFIG:Debug>>:/DEBUG>")
add_link_options("$<$<NOT:$<CONFIG:Debug>>:/OPT:REF>")
add_link_options("$<$<NOT:$<CONFIG:Debug>>:/OPT:ICF>")

add_executable(createdir2 ${sources})

# just for example add some compiler flags
target_compile_options(createdir2 PUBLIC /std:c17)
