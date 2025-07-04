cmake_minimum_required(VERSION 3.10)
project(parameterobjects_baseline C)

file(GLOB sources      main.c)

add_compile_options("$<$<NOT:$<CONFIG:Debug>>:/Zi>")
add_link_options("$<$<NOT:$<CONFIG:Debug>>:/DEBUG>")
add_link_options("$<$<NOT:$<CONFIG:Debug>>:/OPT:REF>")
add_link_options("$<$<NOT:$<CONFIG:Debug>>:/OPT:ICF>")

add_executable(parameterobjects_baseline ${sources})

# just for example add some compiler flags
target_compile_options(parameterobjects_baseline PUBLIC /std:c17)
