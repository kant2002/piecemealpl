cmake_minimum_required(VERSION 3.10)
project(regex_match C)

file(GLOB sources      main.c)

# this is heuristically generated, and may not be correct
find_package(pcre2 CONFIG REQUIRED)

add_compile_options("$<$<NOT:$<CONFIG:Debug>>:/Zi>")
add_link_options("$<$<NOT:$<CONFIG:Debug>>:/DEBUG>")
add_link_options("$<$<NOT:$<CONFIG:Debug>>:/OPT:REF>")
add_link_options("$<$<NOT:$<CONFIG:Debug>>:/OPT:ICF>")

add_executable(regex_match ${sources})

# just for example add some compiler flags
target_compile_options(regex_match PUBLIC /std:c17)
target_link_libraries(regex_match PRIVATE PCRE2::8BIT)
