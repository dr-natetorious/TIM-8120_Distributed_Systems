# Processor Scheduling Articles

## Two CPUs in One (2003)

The author [Mainelli](TwoCpus_In_One.pdf) reports on the performance impact of Pentium Hyperthreading on Windows XP.

Intel's promise was that applications would magically receive benefit, however it was discovered that very few applications correctly handled this case; and some even slowed down.

The slow down was attributed to splitting the memory buffers in half for each virtual processor. There was additional complexities as many applications were not designed to respond to multi-core machines.

![hyperthreading.png](hyperthreading.png)

## Spectre Attacks: Exploiting Speculative Execution (2018)

The authors [Kocher et al.](SpectreAttack.pdf) describe an issue with the branch prediction features that exist within modern processors. These devices use heuristics to precompute likely code branches during idle cycles. If those branches are taken, then the results are committed otherwise they are discarded.

    More specifically, consider an example where the program’s control flow depends on an uncached value located in external physical memory. As this memory is much slower than the CPU, it often takes several hundred clock cycles before the value becomes known. Rather than wasting these cycles by idling, the CPU attempts to guess the direction of control flow, saves a checkpoint of its register state, and proceeds to speculatively execute the program on the guessed path. When the value eventually arrives from memory, the CPU checks the correctness of its initial guess. If the guess was wrong, the CPU discards the incorrect speculative execution by reverting the register state back to the stored checkpoint, resulting in performance comparable to idling. However, if the guess was correct, the speculative execution results are committed, yielding a significant performance gain as useful work was accomplished during the delay. 
    
    From a security perspective, speculative execution involves executing a program in possibly incorrect ways. However, because CPUs are designed to maintain functional correctness by reverting the results of incorrect speculative executions to their prior states, these errors were previously assumed to be safe.

### How does it work

Given enough iterations of `x > 0` the branch predictor will learn to pre-execute the expression `array[x]` and fetch the value from memory into the local processor cache. This cache is shared between the various system processes but protected from direct access by the virtual memory system.

```c++
    if (x < array1_size)
        y = array2[array1[x] * 4096];
```

Low rights processes are capable of evicting the shared processor cache line entries. Since the user controls `x` and `array1` they can cause cache miss that loads `physical_mem[k]` into `processor.cache[base_address + *physical_mem[k])]`. Then by checking the time required to access the cache line can of `processor.cache[base_address + offset]` determine if that value was in the cache or fetched from memory.

If the value `base + offset` was quickly returned from the local cache, then we know that `phyisal_memory[k]` must equal `offset`.

    For this example, a simple and effective gadget would be formed by two instructions (which do not necessarily need to be adjacent) where the first adds (or XORs, subtracts, etc.) the memory location addressed by an attacker-controlled register R1 onto an attacker-controlled register R2, followed by any instruction that accesses memory at the address in R2. In this case, the gadget provides the attacker control (via R1) over which address to leak and control (via R2) over how the leaked memory maps to an address which is read by the second instruction. 
