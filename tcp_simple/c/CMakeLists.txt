cmake_minimum_required(VERSION 3.10)
project(tcp_simple C)

file(GLOB sources      main.c)

add_compile_options("$<$<NOT:$<CONFIG:Debug>>:/Zi>")
add_link_options("$<$<NOT:$<CONFIG:Debug>>:/DEBUG>")
add_link_options("$<$<NOT:$<CONFIG:Debug>>:/OPT:REF>")
add_link_options("$<$<NOT:$<CONFIG:Debug>>:/OPT:ICF>")

add_executable(tcp_simple ${sources})

# just for example add some compiler flags
target_compile_options(tcp_simple PUBLIC /std:c17)
