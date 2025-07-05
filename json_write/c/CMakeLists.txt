cmake_minimum_required(VERSION 3.10)
project(json_write C)

file(GLOB sources      main.c)

# this is heuristically generated, and may not be correct
find_package(cjson CONFIG REQUIRED)
include_directories(${CJSON_INCLUDE_DIR})

add_compile_options("$<$<NOT:$<CONFIG:Debug>>:/Zi>")
add_link_options("$<$<NOT:$<CONFIG:Debug>>:/DEBUG>")
add_link_options("$<$<NOT:$<CONFIG:Debug>>:/OPT:REF>")
add_link_options("$<$<NOT:$<CONFIG:Debug>>:/OPT:ICF>")

add_executable(json_write ${sources})

# just for example add some compiler flags
target_compile_options(json_write PUBLIC /std:c17)
target_link_libraries(json_write PRIVATE cjson)